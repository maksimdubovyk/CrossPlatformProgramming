const express = require("express");
const axios = require("axios");
const bodyParser = require("body-parser");

const app = express();
app.use(cookieParser());
app.use(cors({ credentials: true, origin: "http://localhost:3000" }));
app.use(bodyParser.json());

// Middleware для обробки SameSite=None
app.use((req, res, next) => {
    res.cookie = (name, value, options) => {
        if (options.sameSite === "None" && !options.secure) {
            options.sameSite = "Lax";
        }
        res.append("Set-Cookie", `${name}=${value}; ${Object.entries(options).map(([key, val]) => `${key}=${val}`).join("; ")}`);
    };
    next();
});

// Пример використання cookies
app.get("/set-cookie", (req, res) => {
    res.cookie("testCookie", "testValue", {
        httpOnly: true,
        secure: false, // має бути true у production
        sameSite: "None",
    });
    res.send("Cookie set");
});

const domain = "dev-r617abi65lh733n3.us.auth0.com";
const clientId = "cl28ztazFP3koY3gDgMfSpsDrIxcE974";
const clientSecret = "kMCiGEibvTMkH4o-qtev4oPCbKYNbCimUxBNJYpqT4Pyn8YeTRKADyEHtEd9DVyk";

// Отримання токена для Management API
app.post("/api/token", async (req, res) => {
    try {
        const response = await axios.post(`https://${domain}/oauth/token`, {
            grant_type: "client_credentials",
            client_id: clientId,
            client_secret: clientSecret,
            audience: `https://${domain}/api/v2/`,
        });

        res.json(response.data);
    } catch (error) {
        res.status(500).send("Error fetching token");
    }
});

// Отримання профілю користувача
app.get("/api/user/:userId", async (req, res) => {
    const userId = req.params.userId;

    try {
        // Використовуємо Management API токен
        const tokenResponse = await axios.post(`https://${domain}/oauth/token`, {
            grant_type: "client_credentials",
            client_id: clientId,
            client_secret: clientSecret,
            audience: `https://${domain}/api/v2/`,
        });

        const accessToken = tokenResponse.data.access_token;

        const userResponse = await axios.get(`https://${domain}/api/v2/users/${userId}`, {
            headers: {
                Authorization: `Bearer ${accessToken}`,
            },
        });

        res.json(userResponse.data);
    } catch (error) {
        res.status(500).send("Error fetching user profile");
    }
});

const PORT = 5000;
app.listen(PORT, () => console.log(`Server running on port ${PORT}`));

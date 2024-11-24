import React, { useEffect } from "react";
import { useAuth0 } from "@auth0/auth0-react";
import { Route, Routes, Navigate, Router } from "react-router-dom";
import Cookies from "universal-cookie";
import Layout from "./Components/Layout";
import ProfilePage from "./Components/ProfilePage";
import IndexPage from "./Components/IndexPage";

const cookies = new Cookies();
const App = () => {
    useEffect(() => {
        // Встановлення cookie
        cookies.set("clientCookie", "clientValue", {
            path: "/",
            sameSite: "none",
            secure: true, // має бути true у production
        });

        // Отримання cookie
        const cookieValue = cookies.get("clientCookie");
        console.log("Client Cookie Value:", cookieValue);
    }, []);

    const { isLoading, error, isAuthenticated, user } = useAuth0();

    if (isLoading) return <div>Loading...</div>;
    if (error) return <div>Error: {error.message}</div>;

    return (
        <Layout isAuthenticated={isAuthenticated} userName={user?.name || "Guest"}>
            <Routes>
                <Route path="/" element={<IndexPage />} />
                {/* <Route path="/account/profile" element={isAuthenticated ? <ProfilePage /> : <Navigate to="/" />} /> */}
                {/* <Route path="/account/login" element={<LoginPage />} />
                    <Route path="/account/register" element={<RegisterPage />} />
                    <Route path="/labs/max-profit" element={isAuthenticated ? <MaxProfitPage /> : <Navigate to="/" />} />
                    <Route path="/labs/go-game" element={isAuthenticated ? <GoGamePage /> : <Navigate to="/" />} />
                    <Route path="/labs/board-game" element={isAuthenticated ? <BoardGamePage /> : <Navigate to="/" />} /> */}
            </Routes>
        </Layout>
    );
};

export default App;

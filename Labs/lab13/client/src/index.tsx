import React from "react";
import ReactDOM from "react-dom/client";
import { Auth0Provider } from "@auth0/auth0-react";
import { BrowserRouter as Router } from "react-router-dom";
import "bootstrap/dist/css/bootstrap.min.css";
import "bootstrap/dist/js/bootstrap.bundle.min.js";
import { initializeApiBaseUrl } from "./httpClient";
import App from "./App";
import reportWebVitals from "./reportWebVitals";

const loadConfig = async () => {
    const response = await fetch("/appsettings.json");
    if (!response.ok) {
        throw new Error("Failed to load configuration file");
    }
    return response.json();
};

const renderApp = async () => {
    try {
        const config = await loadConfig();
        const domain = config.Auth0.Domain;
        const clientId = config.Auth0.ClientId;
        await initializeApiBaseUrl();

        const root = ReactDOM.createRoot(document.getElementById("root") as HTMLElement);
        root.render(
            <React.StrictMode>
                <Auth0Provider
                    domain={domain}
                    clientId={clientId}
                    authorizationParams={{
                        redirect_uri: window.location.origin,
                    }}
                >
                    <Router>
                        <App />
                    </Router>
                </Auth0Provider>
            </React.StrictMode>,
        );
    } catch (error) {
        console.error("Error loading app configuration:", error);
    }
};

renderApp();

reportWebVitals();

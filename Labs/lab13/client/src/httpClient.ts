import axios from "axios";

let apiBaseUrl = "";

export const initializeApiBaseUrl = async () => {
    const response = await fetch("/appsettings.json");
    const config = await response.json();
    apiBaseUrl = config.ApiBaseUrl;
};

const httpClient = axios.create({
    baseURL: apiBaseUrl,
});

export default httpClient;

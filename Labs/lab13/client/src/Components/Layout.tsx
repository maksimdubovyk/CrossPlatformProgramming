import React from "react";
import { Link } from "react-router-dom";

interface LayoutProps {
    isAuthenticated: boolean;
    userName?: string;
    children: React.ReactNode;
}

const Layout: React.FC<LayoutProps> = ({ isAuthenticated, userName, children }) => {
    return (
        <div>
            <header>
                <nav className="navbar navbar-expand-sm navbar-toggleable-sm navbar-light bg-white border-bottom box-shadow mb-3">
                    <div className="container-fluid">
                        <Link className="navbar-brand" to="/">
                            Lab5
                        </Link>
                        <button
                            className="navbar-toggler"
                            type="button"
                            data-bs-toggle="collapse"
                            data-bs-target=".navbar-collapse"
                            aria-controls="navbarSupportedContent"
                            aria-expanded="false"
                            aria-label="Toggle navigation"
                        >
                            <span className="navbar-toggler-icon"></span>
                        </button>
                        <div className="navbar-collapse collapse d-sm-inline-flex justify-content-between">
                            <ul className="navbar-nav flex-grow-1">
                                <li className="nav-item">
                                    <Link className="nav-link text-dark" to="/">
                                        Home
                                    </Link>
                                </li>
                                {isAuthenticated ? (
                                    <>
                                        <li>
                                            <Link className="nav-link text-dark" to="/account/profile">
                                                Hello {userName}!
                                            </Link>
                                        </li>
                                        <li>
                                            <Link className="nav-link text-dark" to="/account/logout">
                                                Logout
                                            </Link>
                                        </li>
                                        <li>
                                            <Link className="nav-link text-dark" to="/labs/max-profit">
                                                Max Profit
                                            </Link>
                                        </li>
                                        <li>
                                            <Link className="nav-link text-dark" to="/labs/go-game">
                                                Go Game
                                            </Link>
                                        </li>
                                        <li>
                                            <Link className="nav-link text-dark" to="/labs/board-game">
                                                Board Game
                                            </Link>
                                        </li>
                                    </>
                                ) : (
                                    <>
                                        <li>
                                            <Link className="nav-link text-dark" to="/account/login">
                                                Login
                                            </Link>
                                        </li>
                                        <li>
                                            <Link className="nav-link text-dark" to="/account/register">
                                                Registration
                                            </Link>
                                        </li>
                                    </>
                                )}
                            </ul>
                        </div>
                    </div>
                </nav>
            </header>
            <div className="container">
                <main role="main" className="pb-3">
                    {children}
                </main>
            </div>
        </div>
    );
};

export default Layout;

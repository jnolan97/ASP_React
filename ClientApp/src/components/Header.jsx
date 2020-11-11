import React from "react";
import logo from './imgs/logo.svg';
import { Link } from "react-router-dom";
import './Style.css';

export  function Header() {
    return (
        <header>
            <nav>
                <ul>
                    <li>
                        <Link to="/">
                            <img src={logo} className="App-logo" alt="logo" />
                        </Link>
                    </li>
                </ul>
            </nav>
        </header>
    );
}

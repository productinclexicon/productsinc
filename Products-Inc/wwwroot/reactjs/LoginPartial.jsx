﻿import { Component, Fragment } from 'react';
import React from 'React'

export default class LoginPartial extends Component {
    state = {
        isUserAuthenticated: false}
    }



    }
    render() {
        return (
            <div id="identitybox">
                <ul class="navbar-nav">
                    @if (SignInManager.IsSignedIn(User))
                    {
                        <li class="nav-item">
                            <a class="nav-link text-dark">Hello @User.Identity.Name!</a>
                        </li>
                @*<li class="nav-item">
                        <form class="form-inline" asp-area="Identity" asp-page="/Account/Logout" asp-route-returnUrl="@Url.Action(" Index", "Home", new {area = ""})">
                        <button type="submit" class="nav-link btn btn-link text-dark">Logout</button>
                    </form>
                </li>*@
            }
                else
                {
                @*<li class="nav-item">
                    <a class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Register">Register</a>
                </li>
                <li class="nav-item">
                    <a class="nav-link text-dark" asp-area="Identity" asp-page="/Account/Login">Login</a>
                </li>*@
                <li class="nat-item">
                    <a class="nav-link text-dark">You need to login</a>
                </li>
            }
        </ul>
    </div >
        )
    }
}


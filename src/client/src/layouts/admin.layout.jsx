import React, { Component } from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { Spinner } from "./spinner";

const SignIn = React.lazy(() => import("../pages/sign-in"));
const PermissionDenied = React.lazy(() => import("../pages/error/permission-denied"));
const NotFound = React.lazy(() => import("../pages/error/not-found"));

export default class AdminLayout extends Component {
  render() {
    return (
      <div>
        <header>AdminLayout header</header>
        <div className="container">
          <BrowserRouter>
            <React.Suspense fallback={<Spinner />}>
              <Switch>
                <Route exact path="/admin">
                  <Redirect to="/dashboard" />
                </Route>
                <Route path="/dashboard" render={(props) => <SignIn {...props} />} />
                <Route path="/sign-in" render={(props) => <SignIn {...props} />} />
                <Route path="/denied" render={(props) => <PermissionDenied {...props} />} />
                <Route render={(props) => <NotFound {...props} />} />
              </Switch>
            </React.Suspense>
          </BrowserRouter>
        </div>
        <footer>AdminLayout footer</footer>
      </div>
    );
  }
}

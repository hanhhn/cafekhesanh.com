import React, { Component } from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { Spinner } from "./spinner";
import DefaultHeaderLayout from "./default/default-header.layout";
import DefaultFooterLayout from "./default/default-footer.layout";

const Home = React.lazy(() => import("../pages/home"));
const SignIn = React.lazy(() => import("../pages/sign-in"));
const PermissionDenied = React.lazy(() => import("../pages/error/permission-denied"));
const NotFound = React.lazy(() => import("../pages/error/not-found"));

export default class DefaultLayout extends Component {
  render() {
    return (
      <div>
        <DefaultHeaderLayout />
        <div className="container">
          <BrowserRouter>
            <React.Suspense fallback={<Spinner />}>
              <Switch>
                <Route exact path="/">
                  <Redirect to="/trang-chu" />
                </Route>
                <Route path="/trang-chu" render={(props) => <Home {...props} />} />
                <Route path="/dang-nhap" render={(props) => <SignIn {...props} />} />
                <Route path="/denied" render={(props) => <PermissionDenied {...props} />} />
                <Route render={(props) => <NotFound {...props} />} />
              </Switch>
            </React.Suspense>
          </BrowserRouter>
        </div>
        <DefaultFooterLayout />
      </div>
    );
  }
}

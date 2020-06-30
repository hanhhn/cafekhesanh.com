import React, { Component } from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { Spinner } from "./spinner";
import DefaultHeaderLayout from "./default/default-header.layout";
import DefaultFooterLayout from "./default/default-header.layout";
import "./default/default.layout.scss";

const Home = React.lazy(() => import("../pages/home/home"));
const Product = React.lazy(() => import("../pages/product/product"));
const Products = React.lazy(() => import("../pages/products/products"));
const Contact = React.lazy(() => import("../pages/contact/contact"));
const SignIn = React.lazy(() => import("../pages/sign-in/sign-in"));
const PermissionDenied = React.lazy(() => import("../pages/error/permission-denied"));
const NotFound = React.lazy(() => import("../pages/error/not-found"));

export default class DefaultLayout extends Component {
  render() {
    return (
      <div>
        <DefaultHeaderLayout />
        <main className="container" style={{ minHeight: "calc(100vh - 136px)" }}>
          <BrowserRouter>
            <React.Suspense fallback={<Spinner />}>
              <Switch>
                <Route exact path="/">
                  <Redirect to="/trang-chu" />
                </Route>
                <Route path="/trang-chu" render={(props) => <Home {...props} />} />
                <Route path="/san-pham/:url" render={(props) => <Product {...props} />} />
                <Route path="/san-pham" render={(props) => <Products {...props} />} />
                <Route path="/lien-he" render={(props) => <Contact {...props} />} />
                <Route path="/dang-nhap" render={(props) => <SignIn {...props} />} />
                <Route path="/denied" render={(props) => <PermissionDenied {...props} />} />
                <Route render={(props) => <NotFound {...props} />} />
              </Switch>
            </React.Suspense>
          </BrowserRouter>
        </main>
        <DefaultFooterLayout />
      </div>
    );
  }
}

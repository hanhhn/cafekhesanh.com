import React, { Component } from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { Spinner } from "./spinner";
import { Layout } from "antd";

import DefaultHeaderLayout from "./default/default-header.layout";
import DefaultFooterLayout from "./default/default-footer.layout";
import "./default/default.layout.scss";

const { Header, Footer, Content } = Layout;
const Home = React.lazy(() => import("../pages/home/home"));
const SignIn = React.lazy(() => import("../pages/sign-in/sign-in"));
const PermissionDenied = React.lazy(() => import("../pages/error/permission-denied"));
const NotFound = React.lazy(() => import("../pages/error/not-found"));

export default class DefaultLayout extends Component {
  render() {
    return (
      <Layout>
        <Header style={{ position: "fixed", zIndex: 1, width: "100%", backgroundColor: "#fafafb" }}>
          <DefaultHeaderLayout />
        </Header>
        <Content style={{ marginTop: 64 }}>
          <div className="container" style={{ minHeight: "calc(100vh - 136px)" }}>
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
        </Content>
        <Footer style={{ textAlign: "center" }}>
          <DefaultFooterLayout />
        </Footer>
      </Layout>
    );
  }
}

import React, { Component } from "react";
import { BrowserRouter, Redirect, Route, Switch } from "react-router-dom";
import { Spinner } from "./spinner";
import { Layout, Menu } from "antd";
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
        <Header style={{ position: "fixed", zIndex: 9999, width: "100%", backgroundColor: "#fafafb" }}>
          <Menu theme="light" mode="horizontal" defaultSelectedKeys={["2"]} style={{ backgroundColor: "#fafafb" }}>
            <Menu.Item key="1">nav 1</Menu.Item>
            <Menu.Item key="2">nav 2</Menu.Item>
            <Menu.Item key="3">nav 3</Menu.Item>
          </Menu>
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
        <Footer style={{ textAlign: "center", position: "relative" }}>
          <h1>Footer</h1>
        </Footer>
      </Layout>
    );
  }
}

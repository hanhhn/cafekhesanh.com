import React, { Component } from "react";
import { Space, Card, Divider, Button } from "antd";

import "./home.scss";

export default class Home extends Component {
  render() {
    return (
      <>
        <div className="intro">
          <h1>We love people who code</h1>
          <p>
            We build products that empower developers and connect them to solutions that enable productivity, growth,
            and discovery.
          </p>
          <Button>Default Button</Button>
          <Button type="primary">Primary Button</Button>
        </div>
        <Divider type="horizontal" />
        <div className="product">
          <h1>Cafe mix</h1>
          <Space direction="horizontal">
            <Card title="Card" style={{ width: 300 }}>
              <p>Card content</p>
              <p>Card content</p>
            </Card>
            <Card title="Card" style={{ width: 300 }}>
              <p>Card content</p>
              <p>Card content</p>
            </Card>
          </Space>
        </div>
        <Divider type="horizontal" />
        <div className="original">
          <h1>Cafe Nguyên Chất</h1>
          <Space direction="horizontal">
            <Card title="Card" style={{ width: 300 }}>
              <p>Card content</p>
              <p>Card content</p>
            </Card>
            <Card title="Card" style={{ width: 300 }}>
              <p>Card content</p>
              <p>Card content</p>
            </Card>
          </Space>
        </div>
        <Divider type="horizontal" />
        <div className="story">
          <h1>Coffe Story</h1>
          
        </div>
        <Divider type="horizontal" />
        <div className="gallery">gallery</div>
      </>
    );
  }
}

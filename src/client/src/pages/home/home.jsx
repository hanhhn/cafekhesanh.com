import React, { Component } from "react";
import { Space, Card, Divider, Button, Typography } from "antd";

import Product from "../../components/product/product";
import "./home.scss";

const { Title } = Typography;

export default class Home extends Component {
  render() {
    return (
      <>
        <div className="intro">
          <picture>
            {/* <source media="(min-width:465px)" srcset="img_white_flower.jpg" /> */}
            {/* <img src={home} alt="Flowers" style={{ width: "100%" }} /> */}
          </picture>
          <div className="content">
            <h1>We love people who code</h1>
            <p>
              We build products that empower developers and connect them to solutions that enable productivity, growth,
              and discovery.
            </p>
            <Button>Default Button</Button>
            <Button type="primary">Primary Button</Button>
          </div>
        </div>
        <div className="home-item shipping">
          <ul>
            <li>Freeship1</li>
            <li>Freeship2</li>
            <li>Freeship3</li>
          </ul>
        </div>
        <div className="home-item product">
          <h1>Cafe Mix</h1>
          <div>
            <Product />
          </div>
        </div>
        <div className="home-item original">
          <h1>Cafe Nguyên Chất</h1>
        </div>
        <div className="home-item story">
          <h1>Cafe Story</h1>
        </div>
        <div className="home-item gallery">
          <h1>Cafe Gallery</h1>
        </div>
      </>
    );
  }
}

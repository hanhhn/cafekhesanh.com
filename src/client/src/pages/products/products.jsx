import React, { Component } from "react";
import { Button } from "antd";
import "./products.scss";
import Item from "../../components/item/item";

export default class Products extends Component {
  render() {
    return (
      <>
        <div className="full-container">
          <div className="products">
            <div className="item">
              <Item />
            </div>
            <div className="item">
              <Item />
            </div>
            <div className="item">
              <Item />
            </div>
            <div className="item">
              <Item />
            </div>
            <div className="item">
              <Item />
            </div>
            <div className="item">
              <Item />
            </div>
            <div className="more">
              <Button type="primary">More</Button>
            </div>
          </div>
        </div>
      </>
    );
  }
}

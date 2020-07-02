import React, { Component } from "react";
import { Link } from "react-router-dom";

export default class DefaultHeaderLayout extends Component {
  render() {
    return (
      <header>
        <div className="mobile">mobile</div>
        <div className="desktop container">
          <nav>
            <div className="left">
              <a className="logo" href=".">
                cafekhesanh
              </a>
            </div>
            <div className="right">
              <ul className="menu">
                <li className="menu-item">
                  <Link to="/san-pham">Sản Phẩm</Link>
                </li>
                <li className="menu-item">
                  <Link to="/cafe+">Cafe+</Link>
                </li>
                <li className="menu-item">
                  <Link to="/ve-chung-toi">Về Chúng Tôi</Link>
                </li>
              </ul>
            </div>
          </nav>
        </div>
      </header>
    );
  }
}

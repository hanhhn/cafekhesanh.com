import React, { Component } from "react";

export default class DefaultHeaderLayout extends Component {
  render() {
    return (
      <header>
        <div className="mobile">mobile</div>
        <div className="desktop">
          <nav>
            <div className="left">
              <a className="logo" href=".">
                cafekhesanh
              </a>
            </div>
            <div className="right">
              <ul className="menu">
                <li className="menu-item">Sản Phẩm</li>
                <li className="menu-item">Reviews</li>
                <li className="menu-item">Cafe+</li>
                <li className="menu-item">Về Chúng Tôi</li>
              </ul>
            </div>
          </nav>
        </div>
      </header>
    );
  }
}

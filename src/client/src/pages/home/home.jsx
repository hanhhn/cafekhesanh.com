import React, { Component } from "react";
import { Button, Card } from "antd";
import Product from "../../components/item/item";
import "./home.scss";

const { Meta } = Card;
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
        <div className="home-item horizontal-list">
          <ul>
            <li>Freeship1</li>
            <li>Freeship2</li>
            <li>Freeship3</li>
          </ul>
        </div>
        <div className="home-item product">
          <div className="list">
            <div className="item item1">
              <Product />
            </div>
            <div className="item item2">
              <Product />
            </div>
            <div className="item item3">
              <Product />
            </div>
          </div>
          <div>
            <Button type="primary">Primary Button</Button>
          </div>
        </div>
        <div className="home-item category">
          <h1>Over 1 Million People Have Tried Flamingo. Here’s What Some Have To Say</h1>
          <div className="list">
            <div className="item">
              <h1>Rubuta</h1>
              <p>
                Coffea canephora (syn. Coffea robusta), commonly known as robusta coffee, is a species of coffee that
                has its origins in central and western sub-Saharan Africa. It is a species of flowering plant in the
                family Rubiaceae. Though widely known as Coffea robusta, the plant is scientifically identified as
                Coffea canephora, which has two main varieties, robusta and nganda.
              </p>
              <a href=".">read more</a>
            </div>
            <div className="item">
              <h1>Arabica</h1>
              <p>
                Cà phê chè là tên gọi theo tiếng Việt của loài cà phê Arabica có tên khoa học theo danh pháp hai phần
                là: Coffea arabica, do loài cà phê này có lá nhỏ, cây có một số đặc điểm hình thái giống như cây chè -
                một loài cây công nghiệp phổ biến ở Việt Nam. Cà phê chè có hai loại: cà phê moka và cà phê catimor.
              </p>
              <a href=".">read more</a>
            </div>
          </div>
        </div>
        <div className="home-item original">
          <h1>Cafe Nguyên Chất</h1>
          <div className="list">
            <div className="item item1">
              <Product />
            </div>
            <div className="item item2">
              <Product />
            </div>
            <div className="item item3">
              <Product />
            </div>
            <div className="item item4">
              <Button type="primary">Primary Button</Button>
            </div>
          </div>
        </div>
        <div className="home-item horizontal-list">
          <ul>
            <li>Facebook</li>
            <li>Intagram</li>
            <li>Zalo</li>
            <li>Youtbube</li>
          </ul>
        </div>
        <div className="home-item story">
          <div className="caption">
            <h1>Award-winning products that’ll actually make your bathroom look better? Win, win.</h1>
          </div>
          <div className="image">
            <picture>
              <img
                src="https://images.ctfassets.net/vcddf3kukyq9/1LLajYXEW30bSYMZnqEcWA/3095f75173cbadf95ce76e921061b6d7/_New__Footer_Image.jpg"
                alt=""
              />
            </picture>
          </div>
        </div>
        <div className="home-item gallery">
          <div className="list">
            <div className="item">
              <Card
                hoverable
                style={{ width: "100%" }}
                cover={
                  <img
                    alt="example"
                    src="https://media-coolmate.cdn.vccloud.vn/uploads/June2020/ve-sinh-giay_355x402.jpg"
                  />
                }
              >
                <Meta title="Europe Street beat" description="www.instagram.com" />
              </Card>
            </div>
            <div className="item">
              <Card
                hoverable
                style={{ width: "100%" }}
                cover={
                  <img
                    alt="example"
                    src="https://media-coolmate.cdn.vccloud.vn/uploads/June2020/ve-sinh-giay_355x402.jpg"
                  />
                }
              >
                <Meta title="Europe Street beat" description="www.instagram.com" />
              </Card>
            </div>
            <div className="item">
              <Card
                hoverable
                style={{ width: "100%" }}
                cover={
                  <img
                    alt="example"
                    src="https://media-coolmate.cdn.vccloud.vn/uploads/June2020/ve-sinh-giay_355x402.jpg"
                  />
                }
              >
                <Meta title="Europe Street beat" description="www.instagram.com" />
              </Card>
            </div>
            <div className="item">
              <Card
                hoverable
                style={{ width: "100%" }}
                cover={
                  <img
                    alt="example"
                    src="https://media-coolmate.cdn.vccloud.vn/uploads/June2020/ve-sinh-giay_355x402.jpg"
                  />
                }
              >
                <Meta title="Europe Street beat" description="www.instagram.com" />
              </Card>
            </div>
          </div>
          <div>
            <Button type="primary">Primary Button</Button>
          </div>
        </div>
      </>
    );
  }
}

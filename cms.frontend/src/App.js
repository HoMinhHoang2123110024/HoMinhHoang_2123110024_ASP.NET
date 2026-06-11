import React from 'react';
import CategoryProductList from './components/CategoryProductList';
import ProductList from './components/ProductList'; // Nhớ thêm dòng import này
import PostList from './components/PostList';
import BlogCategoryList from './components/BlogCategoryList';

import './App.css';

function App() {
  return (
    <div className="container mt-5">
      <header className="pb-3 mb-4 border-bottom">
        <span className="fs-4 font-weight-bold text-dark">
          👗 FASHION BOUTIQUE - THỜI TRANG CÔNG SỞ & DẠ HỘI
        </span>
      </header>

      <div className="row">
        {/* Cột bên trái: Danh mục sản phẩm */}
        <div className="col-md-4">
                  <CategoryProductList />
                  <BlogCategoryList />

        </div>
        
        {/* Cột bên phải: Danh sách sản phẩm thời trang tự làm */}
        <div className="col-md-8">
          <h4 className="mb-4 text-uppercase text-secondary font-weight-bold">Bộ sưu tập mới nhất</h4>
          <ProductList />
        </div>
          </div>
      <div className="row mt-5">
        <div className="col-12">
          <PostList />
        </div>
          </div>


          <footer className="pt-3 mt-5 text-muted border-top text-center small">
              <p>© 2026 - Đồ án thực hành phân tầng ASP.NET Core Web API kết hợp ReactJS Client-side</p>
          </footer>
    </div>
  );
}

export default App;
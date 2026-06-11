import axiosClient from '../api/axiosClient';

const blogService = {
    // 1. Hàm lấy danh sách toàn bộ bài viết (Post) từ Backend
    getAllPosts: () => {
        const url = '/Posts'; // Phải khớp chính xác với cấu hình Route trong PostController ở Backend
        return axiosClient.get(url);
    },

    // 2. BÀI TẬP TỰ LÀM: Thêm hàm lấy danh sách Chuyên mục tin tức (Category)
    getBlogCategories: () => {
        const url = '/CategoriesProduct'; // Cần khớp chính xác với [Route("api/Categories")] trong CategoriesController ở Backend
        return axiosClient.get(url);
    }
};

export default blogService;
# HoMinhHoang CMS - Badminton Shop

Đồ án ASP.NET Core (Backend) + ReactJS (Frontend).

## 📁 Cấu trúc dự án

- `CMS.Backend/` - API ASP.NET Core
- `CMS.Data/` - Tầng dữ liệu (EF Core, Models)
- `cms.frontend/` - Giao diện ReactJS

## 🚀 Hướng dẫn chạy dự án

### 1. Chạy Backend (ASP.NET Core)

1. Mở file `HoMinhHoang_Solution.sln` bằng Visual Studio.
2. Chuột phải vào project `CMS.Backend` → **Set as Startup Project**.
3. Mở `appsettings.json`, kiểm tra/chỉnh lại chuỗi kết nối (`ConnectionStrings`) cho khớp với SQL Server trên máy bạn.
4. Mở **Package Manager Console**, chạy lệnh để tạo database (nếu dùng Migration):

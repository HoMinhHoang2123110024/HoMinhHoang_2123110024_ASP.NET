/*
 *Sinh vien: Ho Minh Hoang
 *Ma so: 2123110024
 *Ngay tao: 14-05-2026
 *Version: 1.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Data.Entities
{
    //thuc the danh muc bai viet: Tin Tho su, Tin Giao duc, Tin the thao...
    public class Category
    {
        public int Id { get; set; } // ma danh muc bai viet, khoa chinh
        public string Name { get; set; } // ten danh muc bai viet
        public string Description { get; set; } = string.Empty; // mo ta danh muc bai viet
        public virtual ICollection<Post> Posts { get; set; }
    }
}

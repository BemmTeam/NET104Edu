
namespace NET104.Entities 
{ 
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product 
    { 
        [Key]
        public int Product_Id {get;set;} // primary key

        [Column(TypeName = "nvarchar(100)")]

        [Display(Name = "Tên sản phẩm")]
        public string Name {get;set;}

        [Column(TypeName = "ntext")]

        [Display(Name = "Mô tả")]

        public string Desc {get;set;}

        [Display(Name = "Số lượng")]

        public int Quantity {get; set;}

        [Display(Name = "Giá sản phẩm")]

        public float Price {get;set;} 

        
        [Display(Name = "Hình ảnh")]
        public string Image_Url {get;set;}

        // xác định khóa ngoại
        public int Category_Id {get;set;} 

        [ForeignKey("Category_Id")]
        [Display(Name = "Danh mục")]

        public Category Category {get;set;}
 
    }
}
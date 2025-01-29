using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Data.Entities;

// EF core supports 4 ways to mapping from classes [entities] to table/view 
// 1- By convention [Default]
// 2- By Data Annotation [attributes]

// Entity , Model, Domain model,
// POCO => Plain Old C#/CLR Object
public class Employee
{   
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int EmpId { get; set; } // int
                                // Public numeric property Id , EmployeeId ==> pk , identity(1 , 1)
    [Required]
    // [MaxLength(50)]
    [StringLength(50 , MinimumLength = 10)]
    public string EmpName { get; set; } // nvarchar(max) 
                                    // .NET 5.0 ==> Reference Type : [optional] 
                                    // .NET 6.0 ==> Reference Type string : [required]
                                    // .NET 6.0 ==> Reference Type string ? : [optional]
                                    
    [Column(TypeName = "decimal(18,3)")]
    // [DataType(DataType.Currency)]
    public decimal Salary { get; set; } // decimal(18,2)
                                        // value type : [required]
    [Range(20 , 60)]
    public int? Age { get; set; } // int
                                  // value type : [optional]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    
    [DataType(DataType.Password)]
    public string Password { get; set; }
    
    [Phone]
    [DataType(DataType.PhoneNumber)]
    public string PhoneNumber { get; set; }
                                  
    [Required]
    public string Address { get; set; }
                                  
    // From .NET 6.0 nullable reference types will be mapped to optional 
}
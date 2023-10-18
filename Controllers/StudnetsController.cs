using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;

namespace StudentApp.Models
{
    [ApiController]
    [Route("api/studnets")]
    public class StudnetsController : ControllerBase
    {
        public Studnet[] StudnetList { get; set; }
        public StudnetsController()
        {
            StudnetList = new Studnet[4];
            StudnetList[0] = new Studnet(){
                Number = 1,
                FirstName ="Mohammed",
                LastName = "Almashhor"
            };
            Studnet stu2 = new Studnet();
            stu2.Number= 2;
            stu2.FirstName = "Zain";
            stu2.LastName= "BinYahya";
            StudnetList[1]=stu2;
            StudnetList[2] = new Studnet(){
                Number = 3,
                FirstName ="Ali",
                LastName = "Alhadi"
            };
            StudnetList[3] = new Studnet(){
                Number = 4,
                FirstName ="Mohammed",
                LastName = "Albar"
            };
        }
        [HttpGet]
        public Studnet[] GetAllStudnets(){
            return StudnetList;
        }
        [HttpGet("/{id}:int")]
        public Studnet GetOneStudnet(int id){
            if (id<0 || id>StudnetList.Length)      
            {
                throw new Exception($"There is no Studnet with the number {id}");
            }
            else{
                return StudnetList[id];
            }
        }
        
    }
    
}
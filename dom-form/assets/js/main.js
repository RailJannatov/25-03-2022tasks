// btn = document.querySelector("#button");
// btn.onclick = function(){
//     let named = document.querySelector(".name").value;
//     let surname = document.querySelector(".surname").value;
//     let email = document.querySelector(".email").value;
//     let age = parseInt(document.querySelector(".age").value);
//     let namevalid = false;
//     let surnamevalid = false;
//     let emailvalid = false;
//     let agevalid = false;
//     let valid = false;
//     if(named !== "" && named !== " " && named[0] === named[0].toUpperCase() && named.length > 3){
//         namevalid = true;
//     }
//     else{
//         alert("ss")
//     }
//     if(surname !== "" && surname !== " " && surname[0] === surname[0].toUpperCase() && surname.length > 3){
//         surnamevalid = true;
//     }

//     for (const element of email) {
//         if(email !== "" && email !== " " && element === "@" && email === email.toLowerCase()){
//             emailvalid = true;
//         }
//     }

//     if(age > 0){
//         agevalid = true;
//     }
//     else{
//         alert('this age error')
//     }

//     if (namevalid && surnamevalid && emailvalid && agevalid) {
//         valid = true;
//     }
//     if (valid) {
//         document.getElementById("pname").innerHTML += "<span style='color:rgb(148, 148, 148)'> " + named + "</span>";
//         document.getElementById("psurname").innerHTML += "<span style='color:rgb(148, 148, 148)'> " + surname + "</span>";
//         document.getElementById("pemail").innerHTML += "<span style='color:rgb(148, 148, 148)'> " + email + "</span>";
//         document.getElementById("page").innerHTML += "<span style='color:rgb(148, 148, 148)'> " + age + "</span>";
//         document.getElementById("table").style.display = "none";
//         document.getElementById("result").style.display = "block";
//     }  
// };
// let myParagraph = document.querySelector('.paragraph');
// console.log(myParagraph);

// myParagraph.addEventListener('mouseover',(e)=>{
//      e.target.style.fontSize = "20px";
// })

// myParagraph.addEventListener('mouseleave',(e)=>{
//     console.log('sss');
//     e.target.style.fontSize = "50px";
//     e.target.style.backgrounColor="green";
// })

// class keyClass{
//     constructor(){
//         this.name="this my class"
//     }

//     myMethod(){
//         const that = this;
//         window.addEventListener('keydown',(e)=>{
//             console.log('unique that;',that);
//             that.myAnotherMethod(e)

//         })

//     }

//     myAnotherMethod(e){
//         console.log(this.name);
//         switch (e.keyCode) {
//             case 53:
//                 console.log('this is 5');
//                 break;
//             case 48:
//                 console.log('this is 0');
//             default:
//                 break;
//         }
//     }
// }

// const myObject = new keyClass();
// myObject.myMethod();


//1. Add student to the class
//. Create a method to transfer student from one class to another one
//Inputs: Student, className
function University(name, location, classes = []) {
    this.name = name;
    this.location = location;
    this.classes = classes;
    this.addQrup = (group) => {
        this.classes.push(group)
    }

    this.transferStudent=(student,classname)=>{
        console.log('my classes',this.classes);
        let oldughuqrup = this.classes.find((item)=>{
            
            let sdsnhdjnsd = 
           item.students.some(telebe=>telebe.pin===student.pin);
           
        
        })
        oldughuqrup.removeStudent(student.pin);
        classname.addStudent(student);
    }



    //  
    //   
    //     this.addStudent = (Student,className) =>{
    //         const olanQrup = this.classes.find(qrup => qrup.name === className);
    //         if(olanQrup===undefined){
    //            return console.log("bele class yoxdru")
    //         }
    //         else{
    //             olanQrup.students.push(Student);
    //             console.log(olanQrup);
    //         }
    //     }
    //     }
    // // 1
    // // Arguments: PIN, ClassName
    // // 2. Find all students kiminki GPA-i 80 den yuxaridir
   
    // Add GPA property
 
}
function Class(name, degree, currentYear, students = []) {
    this.name = name;
    this.degree = degree;
    this.currentYear = currentYear;
    this.students = students;
    this.addStudent = (student) => {
        this.students.push(student);
    };
    this.removeStudent = (pin) => {
        this.students = this.students.filter((student) => student.pin !== pin)
    };
}
function Student(name, surname, paid, pin, gpa) {
    this.firstName = name;
    this.lastName = surname;
    this.paid = paid;
    this.pin = pin;
    this.gpa = gpa;

    this.getFullName = () => {
        return this.firstName + ' ' + this.lastName;
    }
}


const Murad = new Student("Murad", "Abdullazade", true, 011, 85);
const Samir = new Student("Samir", "Aliyev", false, 012, 90);
const Fatime = new Student("Fatime", "Bayramova", false, 013, 95);

const BP201 = new Class("Bp201", "Pilot", 2022);
const BP202 = new Class("Bp202", "Zeifler", 2022);

BP201.addStudent(Murad)
BP201.addStudent(Samir)
BP202.addStudent(Fatime)


const BDU = new University("BDu", "Elmler");
BDU.addQrup(BP201);
BDU.addQrup(BP202);

BDU.transferStudent(Samir,BP202);

// console.log('BP201:',BP201);
// console.log('BP202;',BP202);
console.log('BDU',BDU);

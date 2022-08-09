var car1={
    Brand:"Mercedes",
    Model:"E200",
    Color:"White",
    Year:2015,
    Price:20000
}

car1.Year = 2020;

console.log(car1.Year)

console.log(car1.Brand)


var car2 = {
    Brand:"BMW",
    Model:"X6",
    Color:"Gray",
    Year:2017,
    Price:35000
}

car2.Model = "X5";
var cars = [car1,car2,{Brand:"Lada",Model:"07",Year:1998,Price:3000,Color:"White"}]

console.log("Models:")
for(var i=0;i<cars.length;i++){
    if(cars[i].Color=="White")
    console.log(cars[i].Model+" - "+cars[i].Price)
}


var std1 = {
    Name:"Hikmet",
    Surname:"Abbasov",
    Point:68
}
var std2 = {
    Name:"Nezrin",
    Surname:"Abbasova",
    Point:88
}
var std3 = {
    Name:"Abdulla",
    Surname:"Quliyev",
    Point:48
}

var students = [std1,std2,std3]

console.log("Students:")
for(var i=0;i<students.length;i++){
    if(students[i].Point>50){
        console.log(students[i].Name+" "+students[i].Surname+" "+students[i].Point)
    }
}




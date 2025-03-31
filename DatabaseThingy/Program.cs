using DatabaseThingy;
using DatabaseThingy.Actions;

var me = new CreateStudentAction { StudentID = Student.RunningID }
    .SetParam(("Laura", new DateTime(1900, 1, 1)));

var db = new Database();
db.Append(me);
db.Append(
    new CreateStudentAction { StudentID = Student.RunningID }
        .SetParam(("Magda", new DateTime(1900, 2, 2))));
db.Append(
    new CreateStudentAction { StudentID = Student.RunningID }
        .SetParam(("Lisa", new DateTime(1900, 3, 3))));

db.Append(
    new AddEmailAction { StudentID = me.StudentID }
        .SetParam("cool@yahoo.xyz"));

var snapShot = db.GetCurrent(me.StudentID); // has name "Laura"

db.Append(
    new ChangeNameAction { StudentID = me.StudentID }
        .SetParam("Finn"));

var theNewMe = db.GetCurrent(me.StudentID); // has name "Finn"

var x = 5;
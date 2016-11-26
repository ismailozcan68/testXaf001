;#DropDB testXaf001EasyTest

#Application testXaf001.Win
#Application testXaf001.Web

*FillForm
 User Name = Admin
*Action Log On

#IfDef testXaf001.Win

*Action About...
 
*Action OK

#EndIf

#IfDef testXaf001.Web
*Action Navigation(My Details)
#EndIf

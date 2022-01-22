/*• Employe( Mat : int, Nom : varchar(20), Prenom : varchar(20), DN : dateTime, Adresse : varchar(120), 
Tel : varchar(60)) 
• Article( codea : int, Designation : varchar(50), Prix : real, Stock : int ) 
• Production(Num : int, DP : dateTime, Mat : int, codea : int, qtitep : int ) 
• wproduction(Num : int, DP : dateTime, Mat : int, NP : varchar(40), codea : int, Designation : 
varchar(50), qp : int )*/
Use Usine;
go 
CREATE TABLE Employe(
	Mat int PRIMARY KEY ,
	Nom varchar(20),
	Prenom varchar(20),
	DN Date ,
	Adresse varchar(20),
	Tel varchar(20)
);
go  
go 
CREATE TABLE Article(
	codea int PRIMARY KEY ,
	Designation varchar(20),
	Prix float,
	stock int
);
go 
go 
CREATE TABLE Production(
	Num int PRIMARY KEY ,
	DP DATE,
	Mat int FOREIGN KEY REFERENCES Employe(Mat),
	codea int FOREIGN KEY REFERENCES Article(codea),
	qtitep int 
);
go
go 
CREATE TABLE wproduction(
	Num int PRIMARY KEY ,
	DP DATE,
	Mat int FOREIGN KEY REFERENCES Employe(Mat),
	NP int FOREIGN KEY REFERENCES Production(Num),
	codea int FOREIGN KEY REFERENCES Article(codea),
	Designation varchar(20),
	qp int
);
go



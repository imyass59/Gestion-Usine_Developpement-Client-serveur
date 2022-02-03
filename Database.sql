/*• Employe( Mat : int, Nom : varchar(20), Prenom : varchar(20), DN : dateTime, Adresse : varchar(120), 
Tel : varchar(60)) 
• Article( codea : int, Designation : varchar(50), Prix : real, Stock : int ) 
• Production(Num : int, DP : dateTime, Mat : int, codea : int, qtitep : int ) 
• wproduction(Num : int, DP : dateTime, Mat : int, NP : varchar(40), codea : int, Designation : 
varchar(50), qp : int )*/

use Usine;
go

CREATE TABLE Employe(
    Mat int PRIMARY KEY not null,
    Nom varchar(20) not null,
    Prenom varchar(20) not null,
    DN Date not null,
    Adresse varchar(20) not null,
    Tel varchar(20) not null
);
go  
go 
CREATE TABLE Article(
    codea int PRIMARY KEY not null,
    Designation varchar(20) not null,
    Prix float not null,
    stock int not null
);

go
go 
CREATE TABLE wproduction(
    Num int PRIMARY KEY not null,
    DP DATE not null,
    Mat int FOREIGN KEY REFERENCES Employe(Mat) not null,
    NP varchar(50) not null,
    codea int FOREIGN KEY REFERENCES Article(codea) not null,
    Designation varchar(20) not null,
    qp int not null
);

go 
go 
CREATE TABLE Production(
    Num int not null,
    DP DATE not null,
    Mat int FOREIGN KEY REFERENCES Employe(Mat) not null,
    codea int FOREIGN KEY REFERENCES Article(codea) not null,
    qtitep int not null
);

go



go
create proc t2 
as 
begin
	Declare @i int , @c int ,@num_prod int,@date_production date , @mat int ,@code_a int ,@qp int
	set @c = cast((Select count(*) from wproduction) as int)
	set @i = 0;
	while (@i<@c)
		begin
		select @num_prod = Num ,@date_production = DP ,@mat = Mat ,@code_a = codea , @qp =qp from wproduction;
		insert into Production values(@num_prod,@date_production ,@mat,@code_a,@qp);
		set @i = @i +1;
		end
	 
end
go

create proc WproInsert(@num_prod int,@date_production date , @mat int ,@Np varchar(20),@code_a int,@Desig varchar(30) ,@qp int )
as
begin
	insert into wproduction values(@num_prod  ,@date_production   , @mat   ,@Np   ,@code_a  ,@Desig    ,@qp  )

end

go

create procedure parPeriode(@de date, @a date)
as 
begin
	select * from production where dp between @de and @a
end;

go

create procedure fillHistogram
as
begin
	select * from production
end

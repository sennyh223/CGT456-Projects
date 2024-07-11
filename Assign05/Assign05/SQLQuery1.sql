
INSERT INTO Products_Lab5(title, authors, copyrightDate, edition, isbn, coverart, description, price) VALUES('Visual Basic .NET How to Program: Second Edition', 	'Harvey M. Deitel, Paul J. Deitel & Tem R. Nieto', 							'2002', 2, '0-13-029363-6', 'vbnethtp2.png', 	'Microsoft Visual Basic .NET', 		76.00);
INSERT INTO Products_Lab5(title, authors, copyrightDate, edition, isbn, coverart, description, price) VALUES('C++ How to Program: Fourth Edition', 			'Harvey M. Deitel & Paul J. Deitel', 									'2002', 4, '0-13-038474-7', 'cpphtp4.png', 	'Introduces Web Programming with CGI', 	76.00);
INSERT INTO Products_Lab5(title, authors, copyrightDate, edition, isbn, coverart, description, price) VALUES('C# How to Program: First Edition', 			'Harvey M. Deitel, Paul J. Deitel, Jeff Listfield, Tem R. Nieto, Cheryl Yaeger & Marina Zlatkina', 	'2002', 1, '0-13-062221-4', 'csharphtp1.png', 	'Introduces .NET and Web services', 	76.00);



INSERT INTO Assign05Shoes(Name, Description, Color, Laces)

VALUES('Nike', 'Basketball shoes', 'Red', 'Yes');

INSERT INTO Assign05Shoes(Name, Description, Color, Laces)
VALUES('Adidas', 'Running shoes', 'Blue', 'Yes');

INSERT INTO Assign05Shoes(Name, Description, Color, Laces)
VALUES('New Balance', 'Running shoes', 'Black', 'Yes');

INSERT INTO Assign05Shoes(Name, Description, Color, Laces)
VALUES('Converse', 'Shoes', 'White', 'Yes');

INSERT INTO Assign05Shoes(Name, Description, Color, Laces)
VALUES('Under Armor', 'Running shoes', 'Green', 'Yes');

UPDATE Assign05Shoes SET Description='Running shoes' WHERE ShoeID=1;

UPDATE Assign05Shoes SET Description='Basketball shoes' WHERE ShoeID=3;

UPDATE Assign05Shoes SET Description='Skateboard shoes' WHERE ShoeID=4;

SELECT * FROM Assign05Shoes;
SELECT Name FROM Assign05Shoes;

DELETE Assign05Shoes WHERE ShoeID=7;



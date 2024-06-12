USE [CMPT291_Project];
GO

insert into Branch
values
('HQ', 'Some Street', 'Edmonton', 'Alberta', 'Canada'),
('Calgary', 'Not Real Street', 'Calgary', 'Alberta', 'Canada'),
('Red Deer', 'Fake Ave', 'Red Deer', 'Alberta', 'Canada'),
('Lethbridge', 'Dummy Ave', 'Lethbridge', 'Alberta', 'Canada'),
('Airdrie', 'DNE Street', 'Airdrie', 'Alberta', 'Canada');

INSERT INTO CarType VALUES
('Sedan', 100.00, 700.00, 3000.00),
('SUV', 200.00, 1400.00, 6000.00),
('Pickup Truck', 300.00, 2100.00, 9000.00),
('Luxury', 500.00,  3500.00, 150000.00),
('Coupe', 150.00, 1050.00, 4500.00),
('Convertible', 350.00, 2450.00, 10500.00),
('Sports', 400.00, 2800.00, 12000.00),
('Hybrid', 225.00, 1575.00, 6750.00),
('Electric', 250.00, 1750.00, 7500.00),
('Minivan', 125.00, 875.00, 3750.00),
('Hatchback', 175.00, 1225.00, 5250.00);

insert into Car
values
('1HGCM82633A000001', 'Honda', 'Accord', 0, 'ABC123', 'Sedan', 1),
('3N1AB51A21L000002', 'Nissan', 'Sentra', 0, 'XYZ456', 'SUV', 1),
('JT3HN86R7Y0000003', 'Toyota', '4Runner', 0, 'DEF789', 'Pickup Truck', 2),
('1C3CCBBB4CN000000', 'Chrysler', '200', 0, 'GHI321', 'Sedan', 2),
('JH4CL96906C000005', 'Acura', 'TSX', 0, 'JKL987', 'SUV', 3),
('1GNEK13Z12J000006', 'Chevrolet', 'Tahoe', 0, 'MNO654', 'Pickup Truck', 3),
('1J4FA49S72P000007', 'Jeep', 'Wrangler', 0, 'PQR321', 'Sedan', 4),
('2G1WB58KX91100000', 'Chevrolet', 'Impala', 0, 'STU987', 'SUV', 4),
('5FNRL38727B000009', 'Honda', 'Odyssey', 0, 'VWX123', 'Pickup Truck', 5),
('1GKFK63877J000010', 'GMC', 'Yukon', 0, 'YUI456', 'Sedan', 5);

insert into Customer
values 
('John', 'Doe', '1990-05-15', 'AB1234567', '123-456-7890'),
('Jane', 'Smith', '1985-10-20', 'CD9876543', '234-567-8901'),
('Michael', 'Johnson', '1992-03-25', 'EF2468109', '345-678-9012'),
('Emily', 'Brown', '1988-07-10', 'GH1357924', '456-789-0123'),
('Daniel', 'Martinez', '1995-01-05', 'IJ7890123', '567-890-1234'),
('Jessica', 'Garcia', '1993-08-30', 'KL3579246', '678-901-2345'),
('Christopher', 'Rodriguez', '1987-04-12', 'MN5792468', '789-012-3456'),
('Amanda', 'Wilson', '1991-11-18', 'OP1357924', '890-123-4567'),
('Matthew', 'Lopez', '1989-06-22', 'QR7924681', '901-234-5678'),
('Ashley', 'Perez', '1994-02-28', 'ST2468109', '012-345-6789'),
('David', 'Gonzalez', '1986-09-03', 'UV8109246', '987-654-3210'),
('Sarah', 'Lee', '1997-12-08', 'WX1357924', '876-543-2109'),
('Ryan', 'Hernandez', '1996-06-17', 'YZ5792468', '765-432-1098'),
('Jennifer', 'Khan', '1984-11-23', 'AB3579246', '654-321-0987'),
('James', 'Nguyen', '1998-03-02', 'CD1357924', '543-210-9876'),
('Nicole', 'Wang', '1983-01-07', 'EF5792468', '432-109-8765'),
('Brandon', 'Kim', '1990-05-15', 'GH8109246', '321-098-7654'),
('Samantha', 'Patel', '1985-10-20', 'IJ7924681', '210-987-6543'),
('Justin', 'Singh', '1992-03-25', 'KL5792468', '109-876-5432'),
('Melissa', 'Huang', '1988-07-10', 'MN3579246', '098-765-4321')

insert into Employee
values
('William', 'Anderson', 50000.00, 1),
('Sophia', 'Taylor', 60000.00, 1),
('Ethan', 'Williams', 55000.00, 1),
('Olivia', 'Wilson', 52000.00, 2),
('Noah', 'Johnson', 62000.00, 2),
('Charlotte', 'Brown', 53000.00, 2),
('Liam', 'Thompson', 48000.00, 3),
('Amelia', 'Clark', 57000.00, 3),
('Mason', 'Moore', 58000.00, 3),
('Ella', 'Hall', 51000.00, 4),
('Aiden', 'Scott', 64000.00, 4),
('Avery', 'Green', 55000.00, 4),
('Harper', 'Baker', 49000.00, 5),
('Carter', 'Hill', 59000.00, 5),
('Sofia', 'Adams', 57000.00, 5);
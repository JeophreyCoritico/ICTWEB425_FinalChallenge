/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


DELETE FROM [102575814Sale];

DELETE FROM [102575814Customer];

DELETE FROM [102575814Interest];

DELETE FROM [102575814Record];





Insert into [102575814Interest] ([InterestCode], [InterestDesc]) values 
('JA', 'Jazz'),
('RB', 'Rhythm and Blues'),
('RR', 'Rock and Roll');





Insert into [102575814Customer] ([CustNo.], [CustName], [CustAddress], [CustPcode], [InterestCode]) values 
(123, 'Jimmy Barnes', '1 Sesame Street', 3000, 'RR'),
(456, 'Ian Moss', '10 Downing Street', 4000, 'JA'),
(789, 'Don Walker', '221B Baker Street', 5000, 'RB'),
(234, 'Steve Prestwich', 'LG1 College Cres, Parkville', 6000, 'RR'),
(567, 'Phil Small', '1 Adelaide Avenue', 7000, 'RB');



Insert into [102575814Record] ([RecordID], [Title], [Performer]) values
('IX002', 'Kick', 'INXS'),
('IX005', 'Shabooh Shoobah', 'INXS'),
('PF002', 'The Dark Side of the Moon', 'Pink Floyd'),
('PF003', 'The Wall', 'Pink Floyd'),
('PF004', 'The Endless River', 'Pink Floyd'),
('PF006', 'Wish You Were Here', 'Pink Floyd'),
('PF007', 'The Division Bell', 'Pink Floyd'),
('SP069', 'Never Mind the Bollocks', 'Sex Pistols'),
('SP070', 'Floggin a Dead Horse', 'Sex Pistols'),
('SP075', 'Agents of Anarchy', 'Sex Pistols');





Insert into [102575814Sale] ([DateRecorded], [Price], [CustNo.], [RecordID], [InterestCode]) values
('2015-12-1', 30, 123, 'PF003', 'RR'),
('2015-12-1', 29.95, 123, 'IX002', 'RR'),
('2015-12-2', 12.45, 123, 'SP069', 'RR'),
('2015-12-5', 30, 123, 'IX002', 'RR'),
('2015-12-1', 31, 456, 'PF002', 'JA'),
('2015-12-3', 28.95, 456, 'IX005', 'JA'),
('2015-12-6', 13.45, 456, 'SP070', 'JA'),
('2015-12-2', 29, 789, 'PF004', 'RB'),
('2015-12-5', 29.95, 789, 'IX002', 'RB'),
('2015-12-1', 45, 234, 'PF006', 'RR'),
('2015-12-4', 5.67, 234, 'SP075', 'RR'),
('2015-12-3', 9.95, 567, 'PF007', 'RB');

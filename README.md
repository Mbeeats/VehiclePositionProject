# AcmeVendingMachines
Acme Vending Machines Assessment 
In the link below you will find a binary data file which contains a position for each of 2 million vehicles. Your task is to write a program that can find the nearest vehicle position in the data file to each of the 10 co-ordinates provided below. In addition to being able to do this, however, your program must be able to complete all 10 lookups in less time than our benchmark. This benchmark is based on simply looping through each of the 2 million positions and keeping the closest to each given co-ordinate. This is simply repeated for each of the 10 provided co-ordinates.

 

The challenge set to you is to think of a more efficient way to achieve this and to implement it.

 

When you have implemented your solution, please send the entire solution to us to review. Ideally, your solution should be built as a Windows Console Application.

 

The structure of the binary data file is as follows:

Field

Data Type

PositionId

Int32

VehicleRegistration

Null Terminated ASCII String

Latitude

Float (4 byte floating-point number)

Longitude

Float (4 byte floating-point number)

RecordedTimeUTC

UInt64 (number of seconds since Epoch)

 

 

 

The 10 co-ordinates to find the closed vehicle positions to are as follows Position 1 Latitude = 34.544909 Longitude = -102.100843

 

             

Position 2

Latitude = 32.345544

Longitude = -99.123124

 

             

Position 3

Latitude = 33.234235

Longitude = -100.214124

 

             

Position 4

Latitude = 35.195739

Longitude = -95.348899

 

             

Position 5

Latitude = 31.895839

Longitude = -97.789573

 

             

Position 6

Latitude = 32.895839

Longitude = -101.789573

 

             

Position 7

Latitude = 34.115839

Longitude = -100.225732

 

             

Position 8

Latitude = 32.335839

Longitude = -99.992232

 

             

Position 9

Latitude = 33.535339

Longitude = -94.792232

 

             

Position 10

Latitude = 32.234235

Longitude = -100.222222

 

 

Here is the link: https://github.com/MiXTelematics/Recruitment/tree/master

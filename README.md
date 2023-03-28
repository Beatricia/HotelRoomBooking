# HotelRoomBooking
A simple hotel room booking system. 
The user can:
    - See the list with all the rooms(the name of the room, the capacity);
    - Book a room for a specific period and specify the number of people.

The system:
    - Checks if the room is available in the specific period. If not -> success message, else -> error message;
    - Checks if the room can host the specified number of people by the user. If not -> success message, else -> error message;
    - Checks some user input errors like: the start date is after the end date etc.

Technologies used: Blazor, C#, SQLite

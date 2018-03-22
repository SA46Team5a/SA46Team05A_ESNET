# SA46Team05A_ESNET
This is a class project from the GDipSA program in ISS, NUS. The objective is to design and build a sports facility booking system that demonstrates an understanding of UI design, OOP concepts and database design.

## Assumptions
To meet the objective, the team has decided to make simplifying assumptions on the scope of the project without affecting its breadth.

### Available Facilities
- There is only one facility of each type

### Booking rules
- Bookings are made in hourly timeslots, with the first timeslot starting at 8 AM and last timeslot at 7 PM
- Booking can be made only for today and tomorrow
  - For same-day booking, only timeslots after the current hour can be booked. I.e. if the time now is 9.45 AM, only timeslots from 10 am onwards can be booked.
- Members can book any number of hours
- Members can only book one facility for the same timeslot
- Members can book one or more continuous timeslots in one booking

### Membership rules
- Membership lasts 2 years from the date of registration.
- Members can choose to extend their membership

### User identification
- Staff are using company-issued desktops and have to log in with their issued accounts.

## Known Bugs

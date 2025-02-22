using System;
using Domain;
using FluentAssertions;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapacity: 3);

            flight.Book("chefrodneyachery@gmail.com", 1);

            flight.RemainingNumberOfSeats.Should().Be(2);
        }
    }
}
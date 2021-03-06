﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyClassLibrary;

namespace MyTesting
{
    [TestClass]
    public class tstFlights
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create a new instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //test to see if it exists
            Assert.IsNotNull(AnFlight);
        }



        [TestMethod]
        public void FlightNoOK()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "A114";
            //assign the data to the property
            AnFlight.FlightNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.FlightNo, TestData);
        }

        [TestMethod]
        public void AirlineID()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "Air India";
            //assign the data to the property
            AnFlight.Airline = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Airline, TestData);

        }

        [TestMethod]
        public void ArrivalDateOK()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //create some test data
            DateTime ArrivalDate = DateTime.Now.Date;
            AFlight.Arrival = ArrivalDate;
            //test to see if it exists
            Assert.AreEqual(AFlight.Arrival, ArrivalDate);
        }

        [TestMethod]
        public void DepartureDateOK()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //create some test data
            DateTime DepartureDate = DateTime.Now.Date;
            AFlight.Departure = DepartureDate;
            //test to see if it exists
            Assert.AreEqual(AFlight.Departure, DepartureDate);
        }

        [TestMethod]
        public void DestinationOK()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "India";
            //assign the data to the property
            AnFlight.Destination = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.Destination, TestData);

        }

        [TestMethod]
        public void ArrivalAirportOK()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "BHX";
            //assign the data to the property
            AnFlight.ArrivalAirport = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.ArrivalAirport, TestData);

        }


        [TestMethod]
        public void DepartureAirportOK()
        {
            //create instance of class we want to create
            clsFlights AnFlight = new clsFlights();
            //create some test data to assign to the property
            string TestData = "BHX";
            //assign the data to the property
            AnFlight.DepartureAirport = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnFlight.DepartureAirport, TestData);

        }


        [TestMethod]
        public void FlightValidExist()
        {
            //create a new instance of the class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store result of validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AI111";
            string Airline = "AirIndiaaa";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            //OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists 
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "AirIndiaaa";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMaxMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoBoundaryMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMaxPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAaaaa";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FlightNoExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(20, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");



        }

        [TestMethod]
        public void AirlineBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "bb";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "sss";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMaxMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(9, 'a');
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Bhx";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineBoundaryMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "DBX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Bhx";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMaxPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(11, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void AirlineMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "AAAAA";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "Bhx";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void AirlineExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(20, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DestinationMinMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "A";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");

        }

        [TestMethod]
        public void DestinationBoundaryMin()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "DG";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DestinationMinPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "BAL";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DestinationMaxMinus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(9, 'a');
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubaiiiii";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }
        [TestMethod]
        public void DestinationMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "";
            Airline = Airline.PadRight(9, 'a');
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubaiiiiii";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }
        [TestMethod]
        public void DestinationMaxPlus1()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAaaaa";
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubaiiiiiii";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }
        [TestMethod]
        public void DestinationMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "AirIndiaaa";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }
        [TestMethod]
        public void DestinationExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(20, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMinMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.AddYears(-1).ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMinBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = "";
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMinPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMaxMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.AddYears(-364).ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+365).ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMaxPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+366).ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = "";
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+730).ToString(); ;
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMinMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.AddYears(-1).ToString();
            string Departure = DateTime.Now.Date.AddYears(-1).ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMinBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = "";
            string Departure = "";
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMinPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMaxMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = DateTime.Now.Date.AddYears(-364).ToString();
            string Departure = DateTime.Now.Date.AddYears(-364).ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+365).ToString();
            string Departure = DateTime.Now.Date.AddYears(+365).ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMaxPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+366).ToString();
            string Departure = DateTime.Now.Date.AddYears(+366).ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "Dubai Airport";
            string Arrival = "";
            string Departure = "";
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "";
            FlightNo = FlightNo.PadRight(5, 'a');
            string Airline = "Air India";
            string ArrivalAirport = "BHX";
            string Arrival = DateTime.Now.Date.AddYears(+730).ToString();
            string Departure = DateTime.Now.Date.AddYears(+730).ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMinBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "A";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMinPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMaxMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMaxPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void ArrivalAirportExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAAAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "BHX";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMinBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "A";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "A";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMinPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMaxMinusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMaxBoundary()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AAA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMaxPlusOne()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AAAA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportMid()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "aa";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreEqual(OK, "");
        }

        [TestMethod]
        public void DepartureAirportExtermeMax()
        {
            //create an instance of new class we want to create
            clsFlights AFlight = new clsFlights();
            //string variable to store the results of the validation
            string OK = "";
            //create some test data to assign to property
            string FlightNo = "AAAAA";
            string Airline = "Air India";
            Airline = Airline.PadRight(10, 'a');
            string ArrivalAirport = "AAAAA";
            string Arrival = DateTime.Now.Date.ToString();
            string Departure = DateTime.Now.Date.ToString();
            string DepartureAirport = "AAAAA";
            string Destination = "Dubai";
            //Boolean Active = true;
            //invoke method
            OK = AFlight.Valid(FlightNo, Airline, Destination, Arrival, ArrivalAirport, Departure, DepartureAirport);
            //test to see if it exists
            Assert.AreNotEqual(OK, "");
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestFlightIDFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //check the flight no
            if (AnFlight.FlightID != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFlightNoFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //check the flight no
            if (AnFlight.FlightNo != "A114")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAirlineFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //check the flight no
            if (AnFlight.Airline != "Air India")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDestinationFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //check the flight no
            if (AnFlight.Destination != "India")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArrivalFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //check the flight no
            if (AnFlight.Arrival != Convert.ToDateTime("21/06/2018"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartureFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //check the flight no
            if (AnFlight.Departure != Convert.ToDateTime("22/06/2018"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestArrivalAirportFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //check the flight no
            if (AnFlight.ArrivalAirport != "BHX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDepartureAirportFound()
        {
            //create an instance of the class we want to create
            clsFlights AnFlight = new clsFlights();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 FlightID = 1;
            //invoke the method
            Found = AnFlight.Find(FlightID);
            //check the flight no
            if (AnFlight.DepartureAirport != "BHX")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


    }
}

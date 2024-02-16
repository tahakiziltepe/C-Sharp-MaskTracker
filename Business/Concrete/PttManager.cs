﻿using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Citizen citizen)
        {

            if (_applicantService.CheckPerson(citizen))
            {
                Console.WriteLine(citizen.FirstName + " has been given a mask.");
            } 
            else
            {
                Console.WriteLine(citizen.FirstName + " has NOT been given a mask.");
            }

        }
    }
}

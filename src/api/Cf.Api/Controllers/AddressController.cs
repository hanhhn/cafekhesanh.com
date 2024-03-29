﻿using Cf.Libs.Service.Addresses;
using Cf.Libs.Service.Dtos.Adress;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Cf.Api.Controllers
{
    [Route("api/address")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        [Route("province/get")]
        public IEnumerable<AddressUnitDto> GetProvince()
        {
            return _addressService.GetProvince();
        }

        [HttpGet]
        [Route("district/get/{id}")]
        public IEnumerable<AddressUnitDto> GetDistrict(int id)
        {
            return _addressService.GetDistrict(id);
        }

        [HttpGet]
        [Route("ward/get/{id}")]
        public IEnumerable<AddressUnitDto> GetWard(int id)
        {
            return _addressService.GetWard(id);
        }

        [HttpGet]
        [Route("get/{phone}")]
        public IEnumerable<AddressDto> GetFullAddress(string phone)
        {
            return _addressService.GetFullAddress(phone);
        }

        [HttpPost]
        [Route("save")]
        public IEnumerable<AddressDto> SaveAddress(AddressRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(typeof(AddressRequest).ToString());
            }

            if (request.Id > 0)
            {
                return _addressService.Edit(request);
            }
            return _addressService.Add(request);
        }

        [HttpPost]
        [Route("default")]
        public bool SetDefaultAddress(string phone, int id)
        {
            return _addressService.SetDefault(phone, id);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IEnumerable<AddressDto> DeleteAddress(int id)
        {
            return _addressService.Delete(id);
        }
    }
}
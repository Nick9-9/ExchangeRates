﻿using BusinessLogicLayer.DTO;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface ICurrencyService
    {
        CurrencyDefaultInfoDTO GetCurrencyDefaultInfo();
        Task<RatesResponseDTO> GetCurencies();
        Task<CurrencyResponceDto> ConvertCurrency(CurrencyRequestDto currencyRequestDto);        
    }
}

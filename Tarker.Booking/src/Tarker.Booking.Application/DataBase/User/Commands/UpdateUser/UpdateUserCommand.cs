﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarker.Booking.Domain.Entities.User;

namespace Tarker.Booking.Application.DataBase.User.Commands.UpdateUser
{
    public class UpdateUserCommand: IUpdateUserCommand
    {
        private readonly IDataBaseService _dataBaseService;
        private readonly IMapper _mapper;

        public UpdateUserCommand(IDataBaseService dataBaseSerive, IMapper mapper)
        {
            _dataBaseService = dataBaseSerive;
            _mapper = mapper;
        }
        public async Task<UpdateUserModel> Execute(UpdateUserModel model)
        {
            var entity = _mapper.Map<UserEntity>(model);
            _dataBaseService.User.Update(entity);
            await _dataBaseService.SaveAsync();
            return model;
        }
    }
}

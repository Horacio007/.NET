using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Persistence.DataBase;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Api;
using Tarker.Booking.Common;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;
using Tarker.Booking.Application.DataBase.User.Commands.CreateUser;
using Microsoft.AspNetCore.Mvc;
using Tarker.Booking.Application;
using Tarker.Booking.Application.DataBase.User.Commands.UpdateUser;
using Tarker.Booking.Application.DataBase.User.Commands.UpdateUserPassword;
using Tarker.Booking.Application.DataBase.User.Commands.DeleteUser;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

var app = builder.Build();

app.MapPost("/testService", async (IDeleteUserCommand service) =>
{
    //var model = new UpdateUserPasswordModel
    //{
    //    UserId = 2,
    //    //FirstName = "José",
    //    //LastName = "Treviño",
    //    //UserName = "JT",
    //    Password = "jtPassBy11"
    //};
    return await service.Execute(2);
});

app.Run();

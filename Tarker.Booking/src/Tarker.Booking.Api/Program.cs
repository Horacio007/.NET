using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Persistence.DataBase;
using Tarker.Booking.Application.DataBase;
using Tarker.Booking.Api;
using Tarker.Booking.Common;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddWebApi()
    .AddCommon()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

var app = builder.Build();

app.Run();

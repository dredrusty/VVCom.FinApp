﻿namespace FinGo.WebAPI.Model;

public class UserRequest
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;
}
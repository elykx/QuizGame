﻿namespace QuizGame.Contracts.Authentication
{
    public record RegisterRequest(
        string Name,
        string Email,
        string Password);
}
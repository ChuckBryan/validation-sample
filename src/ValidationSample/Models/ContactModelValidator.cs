﻿namespace ValidationSample.Models
{
    using System;
    using FluentValidation;

    public class ContactModelValidator : AbstractValidator<ContactModel>
    {
        public ContactModelValidator()
        {
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Email).NotNull().EmailAddress();
            RuleFor(x => x.DateOfBirth).NotNull().LessThanOrEqualTo(DateTime.Today);
            RuleFor(x => x.PhoneNumber).NotNull().Matches(@"\d{3}-\d{3}-\d{4}");
        }
    }
}
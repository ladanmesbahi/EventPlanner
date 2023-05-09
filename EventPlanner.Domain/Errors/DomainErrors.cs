using EventPlanner.Domain.Shared;

namespace EventPlanner.Domain.Errors
{
    public static class DomainErrors
    {
        public static class Email
        {
            public static readonly Error Empty = new(
                "Email.Empty",
                "Email is empty");

            public static readonly Error InvalidFormat = new(
                "Email.InvalidFormat",
                "Email format is invalid");
        }
        public static class FirstName
        {
            public static readonly Error Empty = new(
                "FirstName.Empty",
                "First name is empty");
            public static readonly Error TooLong = new(
                "FirstName.TooLong",
                "First name is too long");
        }
        public static class LastName
        {
            public static readonly Error Empty = new(
                "LastName.Empty",
                "Last name is empty");
            public static readonly Error TooLong = new(
                "LastName.TooLong",
                "Last name is too long");
        }

        public static class Conference
        {
            public static readonly Error InvitingCreator = new(
                "Conference.InvitingCreator",
                "Can't send invitation to the Conference creator");

            public static readonly Error AlreadyPassed = new(
               "Conference.AlreadyPassed",
               "Can't send invitation for Conference in the past");

            public static readonly Error Expired = new(
                "Conference.Expired",
                "Can't accept invitation for expired Conference");
        }
    }
}

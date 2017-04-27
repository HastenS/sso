﻿namespace sso.Ticket
{
    public interface ITicketInfoProtector
    {
        string Protect(TicketInfo ticket);

        TicketInfo UnProtect(string token);
    }
}

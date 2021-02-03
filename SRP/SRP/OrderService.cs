﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SRP
{
    class OrderService : Program
    {
        private readonly SmtpClient _smtpClient;

        public OrderService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public async Task Add(Order order)
        {
            // 01. Código para crear la orden

            // 02. Notificar al cliente
            var message = new MailMessage("sales@admin.com", order.ClientEmail)
            {
                Subject = "Se le asignó una compra",
                Body = "Estimado,\n Hemos creado su nueva orden de compra .."
            };

            await this.SendCustomerNotification(message);
        }

        public async Task SendCustomerNotification(MailMessage message)
        {
            await _smtpClient.SendMailAsync(message);
        }
    }
}

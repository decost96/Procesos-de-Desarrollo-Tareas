using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            public class NotificationService
        {
            private readonly SmtpClient _smtpClient;

            public NotificationService(SmtpClient smtpClient)
            {
                _smtpClient = smtpClient;
            }

            public async Task SendEmail(MailMessage message)
            {
                await _smtpClient.SendMailAsync(message);
            }
        }

        public class OrderService
        {
            private readonly NotificationService _notificationService;

            public OrderService(NotificationService notificationService)
            {
                _notificationService = notificationService;
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

                await this._notificationService.SendEmail(message);
            }
        }
    }
}

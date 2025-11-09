namespace QMS.QueueCommunication;

public static class RabbitMQConstants
{
    public const string Host = "localhost";
    public const string Uri = "amqp://localhost";
    public const string Username = "guest";
    public const string Password = "guest";

    public const string TakeNumberQueueName = "take-number";
    public const string CallNumberQueueName = "call-number";
    public const string CompleteQueueQueueName = "complete-queue";
}

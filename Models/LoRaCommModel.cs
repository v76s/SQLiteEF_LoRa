namespace SQLiteEF_LoRa.Models
{
    public class LoRaCommModel
    {
        // Unique identifier for the gateway
        public string Id { get; set; } = String.Empty;

        // Timestamp when the message was received
        public DateTime Timestamp { get; set; } = DateTime.Now;

        // Frequency at which the message was transmitted
        public double Frequency { get; set; }

        // Data rate of the transmission
        public string DataRate { get; set; }

        // Signal-to-noise ratio of the received message
        public double SNR { get; set; }

        // Received signal strength indicator
        public int RSSI { get; set; }

        // Payload of the message
        public string Payload { get; set; }

        // Device address (unique identifier for the device)
        public string DeviceAddress { get; set; }

        // Frame counter of the message
        public uint FrameCounter { get; set; }

        // Port number used in the transmission
        public byte Port { get; set; }

        // CRC status (true if valid, false if invalid)
        public bool CRCStatus { get; set; }

        // Length of the received message
        public int MessageLength { get; set; }

        // Constructor
        public LoRaCommModel(string gatewayId, DateTime timestamp, double frequency, string dataRate, double snr, int rssi, string payload, string deviceAddress, uint frameCounter, byte port, bool crcStatus, int messageLength)
        {
            Id = gatewayId;
            Timestamp = timestamp;
            Frequency = frequency;
            DataRate = dataRate;
            SNR = snr;
            RSSI = rssi;
            Payload = payload;
            DeviceAddress = deviceAddress;
            FrameCounter = frameCounter;
            Port = port;
            CRCStatus = crcStatus;
            MessageLength = messageLength;
        }

        // Default constructor
        public LoRaCommModel() { }

        // Override ToString() method for better debugging
        public override string ToString()
        {
            return $"GatewayId: {Id}, Timestamp: {Timestamp}, Frequency: {Frequency}, DataRate: {DataRate}, SNR: {SNR}, RSSI: {RSSI}, Payload: {Payload}, DeviceAddress: {DeviceAddress}, FrameCounter: {FrameCounter}, Port: {Port}, CRCStatus: {CRCStatus}, MessageLength: {MessageLength}";
        }
    }
}

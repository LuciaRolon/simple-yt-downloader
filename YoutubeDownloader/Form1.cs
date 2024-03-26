using YoutubeExplode;
using YoutubeExplode.Videos.Streams;
using NReco.VideoConverter;


namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        YoutubeClient ytClient;
        public Form1()
        {
            InitializeComponent();
            ytClient = new YoutubeClient();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (txtVideoUrl.Text == "" || txtVideoName.Text == "") return;
            var streamManifest = await ytClient.Videos.Streams.GetManifestAsync(txtVideoUrl.Text);
            var streamInfo = streamManifest.GetAudioOnlyStreams().GetWithHighestBitrate();
            if (cmbVideoType.SelectedItem.ToString() == "Video")
            {
                streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();
            }
            string filePath = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/{txtVideoName.Text}";            
            await ytClient.Videos.Streams.DownloadAsync(streamInfo, $"{filePath}.{streamInfo.Container}");
            if(cmbVideoType.SelectedItem.ToString() == "MP3")
            {
                var ffMpeg = new FFMpegConverter();
                ffMpeg.ConvertMedia($"{filePath}.{streamInfo.Container}", $"{filePath}.mp3", "mp3");
                File.Delete($"{filePath}.{streamInfo.Container}");
            }            
            MessageBox.Show("Video downloaded");
        }
    }
}
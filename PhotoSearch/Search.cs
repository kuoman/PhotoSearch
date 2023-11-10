namespace PhotoSearch
{
    public record Search
    {
        public string GetPhoto(int photoId)
        {
            if (photoId == 54) return "[54] ut ex quibusdam dolore mollitia";
            return "[53] soluta et harum aliquid officiis ab omnis consequatur";
        }
    }
}
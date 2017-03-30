var config = {}

config.host = process.env.HOST || "https://sampledocumentdb66.documents.azure.com:443/";
config.authKey = process.env.AUTH_KEY || "8OVRnNPjWhumstZqypx8CqfuaMSXLNfomBOc1ACgy4cBaYFyf8kNx34tGSNJFTPjNeBIqN4efJuFHtSk2Crz2A==";
config.databaseId = "ToDoList";
config.collectionId = "Items";

module.exports = config;

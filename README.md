ChatGLM4的四种调用方式
当前的大语言模型基本上支持四种调用的方式，分别是原生SDK调用、OpenAI SDK调用、Langchain SDK的调用和http协议的调用，所以对接起来是非常方便的


pip install zhipuai
 
SDK 用户鉴权
我们的所有 API 使用 API Key 进行身份验证。您可以访问智谱AI开放平台 API Keys 页面 查找您将在请求中使用的 API Key。
Python SDK 创建 Client
我们已经将接口鉴权封装到 SDK，您只需按照 SDK 调用示例填写 API Key 即可，示例如下
 



OpenAI SDK 使用

安装 OpenAI SDK
需要确保使用的 Python 版本至少为 3.7.1， OpenAI SDK 版本不低于 1.0.0
pip install openai
 

使用 API Key 鉴权
创建 Client，使用您在开放平台的API Key 鉴权。示例如下：

填入智谱开发平台申请的API Keys




Langchain SDK 使用
安装 Langchain SDK
首先需要安装 Langchain 和 对应的依赖包，请确保 langchain_community 的版本在 0.0.32 以上。
pip install langchain
 

使用 Langchain ChatOpenAI
Langchain 的ChatOpenAI类是对 OpenAI SDK 的封装，可以更方便调用。这里展示了如何使用 ChatOpenAI 类来调用 GLM-4 模型。





 
 

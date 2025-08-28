# Qoder Editor for Unity

[![Unity Version](https://img.shields.io/badge/Unity-2019.2%2B-blue.svg)](https://unity3d.com/get-unity/download)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE.md)
[![Version](https://img.shields.io/badge/version-1.0.1-blue.svg)](CHANGELOG.md)

**Qoder Editor for Unity** 是一个官方包，用于将 Qoder IDE 与 Unity 游戏引擎集成。该包提供代码智能感知、项目文件生成和编辑器集成功能，让 Unity 开发者能够在 Qoder 中获得完整的开发体验。

## 🌟 特性

- **自动检测 Qoder IDE**: 自动查找系统中安装的 Qoder IDE
- **智能项目文件生成**: 自动生成 `.csproj` 和 `.sln` 文件以支持代码智能感知
- **跨平台支持**: 完全支持 Windows、macOS 和 Linux
- **集成开发体验**: 直接从 Unity 编辑器打开脚本文件
- **可配置选项**: 在 Unity Preferences 中自定义 Qoder 启动参数
- **包支持**: 支持各种类型的 Unity 包（Embedded、Local、Registry、Git、Built-in）
- **隐藏 .meta 文件**: 默认在项目资源管理器中隐藏 .meta 文件，保持项目结构清晰

## 📋 系统要求

- **Unity**: 2019.2 或更高版本
- **Qoder IDE**: 需要安装 Qoder 编辑器
- **Git**: 用于通过 Git URL 安装包

## ⚡ 快速安装

### 通过 Git URL 安装

1. 在 Unity 中打开 **Window > Package Manager**
2. 点击 **"+"** 按钮，选择 **"Add package from git URL..."**
3. 输入以下 URL:
   ```
   https://github.com/wweibp/QoderForUntiy.git
   ```
4. 点击 **"Add"** 并等待安装完成

### 手动安装

1. 克隆或下载此仓库
2. 将包文件夹放入 Unity 项目的 `Packages` 目录中

## 🛠️ 配置

### 设置外部脚本编辑器

1. 打开 **Edit > Preferences > External Tools** (Windows) 或 **Unity > Preferences > External Tools** (macOS)
2. 在 **External Script Editor** 下拉菜单中选择 **Qoder**
3. 如果 Qoder 未被自动检测到，请手动浏览选择 Qoder 可执行文件

### Qoder 安装路径

**Windows:**
- `%LOCALAPPDATA%\Programs\Qoder\Qoder.exe`
- `%PROGRAMFILES%\Qoder\Qoder.exe`

**macOS:**
- `/Applications/Qoder.app`

**Linux:**
- `/usr/bin/qoder`
- `/usr/local/bin/qoder`

## 🚀 使用方法

### 打开脚本文件

1. 在 Project 窗口中双击任何 C# 脚本文件
2. 脚本将在 Qoder IDE 中打开，支持语法高亮和智能感知

### 生成项目文件

1. 选择 **Assets > Open C# Project**
2. 该操作将生成项目文件并启动 Qoder IDE

### 配置项目生成选项

在 Unity Preferences 中，可以配置为哪些类型的包生成项目文件：
- Embedded packages
- Local packages
- Registry packages
- Git packages
- Built-in packages
- Packages from unknown sources

## 🧪 测试

该包包含完整的单元测试套件，可通过 Unity Test Runner 运行：

1. 打开 **Window > General > Test Runner**
2. 切换到 **EditMode** 标签
3. 运行测试以验证功能

## 📁 项目结构

```
com.unity.ide.qoder/
├── Editor/
│   ├── ProjectGeneration/     # 项目文件生成逻辑
│   ├── QoderDiscovery.cs      # Qoder IDE 自动发现
│   └── QoderScriptEditor.cs   # Qoder IDE 集成入口
├── Tests/                     # 单元测试
│   ├── QoderDiscoveryTests.cs
│   └── QoderScriptEditorTests.cs
├── package.json               # 包配置文件
└── README.md                  # 项目文档
```

## 🔧 故障排除

### Qoder 未被检测到

1. 确保 Qoder IDE 已正确安装
2. 检查 Qoder 可执行文件是否存在
3. 手动设置 Qoder 路径

### 智能感知不工作

1. 使用 **Assets > Open C# Project** 重新生成项目文件
2. 重启 Qoder IDE
3. 检查 `.csproj` 文件是否已生成

### 安装问题

1. 检查网络连接
2. 验证 Git URL 是否正确
3. 确保 Git 已正确安装

## 📚 文档

- [安装指南](INSTALLATION.md)
- [快速开始](QUICKSTART.md)
- [更新日志](CHANGELOG.md)
- [贡献指南](CONTRIBUTING.md)

## 📄 许可证

该项目基于 [MIT 许可证](LICENSE.md) 授权。

## 🤝 贡献

欢迎贡献！请阅读 [贡献指南](CONTRIBUTING.md) 了解更多信息。

## 📞 支持

如有问题，请创建 [GitHub Issue](https://github.com/wweibp/QoderForUntiy/issues)。
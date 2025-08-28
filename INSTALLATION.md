# Qoder Editor for Unity - 安装指南

本文档详细介绍如何通过 Git URL 在 Unity 中安装 Qoder Editor 包。

## 📋 前置要求

在开始安装之前，请确保：

- **Unity 版本**: 2019.2 或更高版本
- **Git**: 系统中已安装 Git（用于从 Git URL 下载包）
- **Qoder**: 已在系统中安装 Qoder 编辑器
- **网络连接**: 能够访问 GitHub（或你的 Git 仓库）

## 🔧 安装步骤

### 步骤 1: 打开 Package Manager

1. 启动 Unity Editor
2. 在顶部菜单栏中选择 **Window > Package Manager**
3. Package Manager 窗口将会打开

### 步骤 2: 添加 Git URL 包

1. 在 Package Manager 窗口的左上角，点击 **"+"** 按钮
2. 从下拉菜单中选择 **"Add package from git URL..."**
3. 将会出现一个文本输入框

### 步骤 3: 输入 Git URL

在文本框中输入以下 URL：

```
https://github.com/95700900/QoderForUntiy.git
```

> **重要提示**: 请将 `95700900` 替换为实际的 GitHub 用户名或组织名（如果仓库地址有变化）。

### 步骤 4: 完成安装

1. 点击 **"Add"** 按钮
2. Unity 将开始下载并导入包
3. 等待安装完成（通常需要几秒到几分钟）
4. 安装完成后，包将出现在 Package Manager 的 "In Project" 列表中

## 🎯 验证安装

安装完成后，请验证包是否正确安装：

### 检查包状态

1. 在 Package Manager 中，确保 "Qoder Editor" 包显示在 "In Project" 部分
2. 包的状态应该显示为已安装（绿色勾选标记）

### 检查文件结构

在 Project 窗口中，你应该能看到：

```
Packages/
└── Qoder Editor/
    ├── Editor/
    │   ├── ProjectGeneration/
    │   ├── QoderDiscovery.cs
    │   ├── QoderScriptEditor.cs
    │   └── ...
    ├── Tests/
    │   ├── QoderDiscoveryTests.cs
    │   └── QoderScriptEditorTests.cs
    ├── package.json
    ├── README.md
    └── ...
```

### 检查 External Tools 设置

1. 打开 **Edit > Preferences**（Windows）或 **Unity > Preferences**（macOS）
2. 在左侧菜单中选择 **External Tools**
3. 在 **External Script Editor** 下拉菜单中，应该能看到 Qoder 选项

## ⚙️ 配置 Qoder

### 自动配置

如果 Qoder 安装在标准位置，包会自动检测并配置：

**Windows 常见路径:**
- `%LOCALAPPDATA%\Programs\Qoder\Qoder.exe`
- `%PROGRAMFILES%\Qoder\Qoder.exe`
- `%PROGRAMFILES(X86)%\Qoder\Qoder.exe`

**macOS 常见路径:**
- `/Applications/Qoder.app`
- `/usr/local/bin/qoder`

**Linux 常见路径:**
- `/usr/bin/qoder`
- `/usr/local/bin/qoder`
- `/snap/qoder/current/bin/qoder`

### 手动配置

如果自动检测失败：

1. 在 **External Tools** 设置中
2. 点击 **External Script Editor** 右侧的浏览按钮
3. 手动选择 Qoder 的可执行文件
4. 点击 **Apply** 保存设置

## 🧪 测试安装

### 测试 1: 打开脚本文件

1. 在 Project 窗口中创建或选择一个 C# 脚本文件
2. 双击该文件
3. Qoder 应该启动并打开该文件

### 测试 2: 检查项目文件生成

1. 在 Unity 菜单中选择 **Assets > Open C# Project**
2. 这应该会生成 `.csproj` 和 `.sln` 文件
3. Qoder 应该打开项目并提供智能感知功能

### 测试 3: 运行单元测试（可选）

1. 打开 **Window > General > Test Runner**
2. 切换到 **EditMode** 标签
3. 运行 Qoder 相关的测试以验证功能

## 🔄 更新包

要更新到最新版本：

### 方法 1: 通过 Package Manager

1. 在 Package Manager 中找到 "Qoder Editor" 包
2. 如果有可用更新，会显示 "Update" 按钮
3. 点击 "Update" 按钮

### 方法 2: 重新安装

1. 在 Package Manager 中选择 "Qoder Editor" 包
2. 点击 "Remove" 卸载包
3. 重新按照安装步骤添加最新版本

## 🗑️ 卸载包

如需卸载：

1. 在 Package Manager 中找到 "Qoder Editor" 包
2. 选择该包
3. 点击 "Remove" 按钮
4. 确认卸载

## ❗ 故障排除

### 常见问题

#### 问题 1: "Cannot resolve package"
**解决方案:**
- 检查网络连接
- 验证 Git URL 是否正确
- 确保 Git 已正确安装
- 尝试在命令行中手动克隆仓库以测试连接

#### 问题 2: "Package does not contain a valid package.json"
**解决方案:**
- 确保 Git URL 指向包含 `package.json` 的正确分支
- 检查仓库结构是否正确

#### 问题 3: Qoder 未被检测到
**解决方案:**
- 确保 Qoder 已正确安装
- 检查 Qoder 可执行文件的权限
- 手动设置 Qoder 路径

#### 问题 4: 智能感知不工作
**解决方案:**
- 使用 **Assets > Open C# Project** 重新生成项目文件
- 重启 Qoder 编辑器
- 检查 `.csproj` 文件是否已生成

### 获取帮助

如果遇到其他问题：

1. 查看 Unity Console 中的错误信息
2. 检查 [GitHub Issues](https://github.com/95700900/QoderForUntiy/issues)
3. 创建新的 Issue 报告问题

## 📚 其他资源

- [主要文档](README.md)
- [更新日志](CHANGELOG.md)
- [贡献指南](CONTRIBUTING.md)
- [Unity Package Manager 文档](https://docs.unity3d.com/Manual/upm-ui.html)

---

**注意**: 本文档基于 Unity 2019.2+ 版本编写。不同版本的 Unity 界面可能略有不同，但基本步骤相同。
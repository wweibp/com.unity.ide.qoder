# 📋 Git URL 包发布检查清单

在将包发布到 Git 仓库供他人通过 Git URL 安装之前，请确保完成以下检查项。

## ✅ 必需文件检查

- [x] `package.json` - 包含正确的包信息和元数据
- [x] `README.md` - 完整的项目文档和使用说明
- [x] `CHANGELOG.md` - 版本更新历史
- [x] `LICENSE.md` - 开源许可证
- [x] `CONTRIBUTING.md` - 贡献指南
- [x] `INSTALLATION.md` - 详细安装指南
- [x] `QUICKSTART.md` - 快速开始指南
- [x] `.gitignore` - 正确的 Git 忽略规则

## ✅ 代码文件检查

- [x] `Editor/` 目录包含所有编辑器脚本
- [x] `Tests/` 目录包含单元测试
- [x] 程序集定义文件 (.asmdef) 正确配置
- [x] 清理了旧的 VSCode 相关文件

## ✅ package.json 验证

验证 `package.json` 包含以下必需字段：

- [x] `name` - 包名称 (com.unity.ide.qoder)
- [x] `displayName` - 显示名称
- [x] `description` - 包描述
- [x] `version` - 版本号 (1.0.0)
- [x] `unity` - 最低 Unity 版本要求
- [x] `author` - 作者信息
- [x] `license` - 许可证
- [x] `repository` - Git 仓库信息
- [x] `keywords` - 搜索关键词

## ✅ Git 仓库检查

### 提交前检查
- [ ] 确保所有更改都已提交到 Git
- [ ] 检查是否有未跟踪的重要文件
- [ ] 验证 `.gitignore` 工作正常

### 远程仓库设置
- [ ] 创建 GitHub 仓库（如果尚未创建）
- [ ] 设置正确的远程 URL
- [ ] 推送所有分支和标签

## ✅ 文档检查

### README.md
- [x] 项目描述清晰
- [x] 安装说明完整
- [x] 使用指南详细
- [x] 故障排除部分
- [x] 包含 Git URL 安装步骤

### 其他文档
- [x] INSTALLATION.md 详细安装步骤
- [x] QUICKSTART.md 快速上手指南
- [x] CHANGELOG.md 版本历史

## ✅ 功能测试

### 基本功能
- [ ] 在新的 Unity 项目中测试 Git URL 安装
- [ ] 验证 Qoder 自动检测功能
- [ ] 测试脚本文件打开功能
- [ ] 验证项目文件生成功能

### 跨平台测试（可选）
- [ ] Windows 平台测试
- [ ] macOS 平台测试
- [ ] Linux 平台测试

## ✅ 版本管理

### Git 标签
- [ ] 为当前版本创建 Git 标签
  ```bash
  git tag -a v1.0.0 -m "Release version 1.0.0"
  git push origin v1.0.0
  ```

### 版本号更新
- [ ] 确保 `package.json` 中的版本号正确
- [ ] 更新 `CHANGELOG.md` 中的版本信息

## 🚀 发布步骤

1. **最终代码检查**
   ```bash
   # 检查 Git 状态
   git status
   
   # 检查是否有未提交的更改
   git diff
   ```

2. **提交所有更改**
   ```bash
   git add .
   git commit -m "Prepare package for Git URL installation"
   ```

3. **创建版本标签**
   ```bash
   git tag -a v1.0.0 -m "Release version 1.0.0"
   ```

4. **推送到远程仓库**
   ```bash
   git push origin main
   git push origin v1.0.0
   ```

5. **更新 README.md 中的 URL**
   - 将所有 `95700900` 替换为实际的 GitHub 用户名
   - 确保 Git URL 正确

## 📝 发布后测试

### 验证安装
1. 在新的 Unity 项目中测试 Git URL 安装
2. 使用完整的 Git URL：
   ```
   https://github.com/95700900/QoderForUntiy.git
   ```

### 验证功能
1. 确认包正确安装
2. 测试 Qoder 集成功能
3. 验证智能感知是否工作

## 🎯 完成检查

当所有检查项都完成后，包就可以被其他用户通过 Git URL 安装了！

---

**提示**: 建议在不同的 Unity 项目中测试安装过程，确保一切正常工作。
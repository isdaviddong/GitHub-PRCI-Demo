# GitHub Actions PR-CI Demo

這是一個示範專案，用於展示如何使用 GitHub Actions 建立 Pull Request 的 CI (持續整合) 流程。

## CI 工作流程說明

本專案的 `.github/workflows/demo-prci.yml` 配置了以下自動化流程：

1. 觸發條件：
   - 當發起 Pull Request 到 `main` 分支時

2. 執行環境：
   - 使用最新版本的 Ubuntu
   - .NET 8.0 SDK

3. CI 檢查項目：
   - 建置專案
   - 執行單元測試
   - AI 程式碼審查

4. 工作流程步驟：
   - 檢出程式碼 (使用 actions/checkout@v3)
   - 設定 .NET 環境 (使用 actions/setup-dotnet@v4)
   - 還原相依套件
   - 建置專案
   - 取得 Pull Request 的程式碼差異 (diff)
   - 呼叫 OpenAI API 進行程式碼審查，分析程式碼差異，並提供技術債、壞味道與重構建議
   - 將 OpenAI 的審查意見作為評論回覆到 Pull Request
   - 執行測試 (包含測試報告產出)

這個 CI 流程可以確保每個 Pull Request 的程式碼品質，避免不符合規範的程式碼被合併到主分支，並透過 AI 提供額外的程式碼審查建議，提升程式碼的可維護性與品質。

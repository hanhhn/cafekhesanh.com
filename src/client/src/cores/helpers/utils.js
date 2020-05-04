// declare const window: any;

export function showSpinner() {
  const blockUI = window.blockUI;

  if (blockUI) {
    blockUI.style.display = "block";
  }
}

export function hideSpinner() {
  const blockUI = window.blockUI;

  if (blockUI) {
    setInterval(() => {
      blockUI.style.display = "none";
    }, 2000);
  }
}
